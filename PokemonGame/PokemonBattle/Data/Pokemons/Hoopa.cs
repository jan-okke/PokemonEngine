using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hoopa : Pokemon
	{
		public override string Name => "Hoopa";
		public override List<Ability> AvailableAbilities => new() {new Magician() };
		public override Stats BaseStats => new Stats(80, 110, 60, 150, 130, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Hyperspacehole(), new Trick(), new Destinybond(), new Allyswitch(), new Confusion() },
			[6] = new List<Move>() { new Astonish() },
			[10] = new List<Move>() { new Magiccoat() },
			[15] = new List<Move>() { new Lightscreen() },
			[19] = new List<Move>() { new Psybeam() },
			[25] = new List<Move>() { new Skillswap() },
			[29] = new List<Move>() { new Powersplit(), new Guardsplit() },
			[35] = new List<Move>() { new Phantomforce() },
			[46] = new List<Move>() { new Zenheadbutt() },
			[50] = new List<Move>() { new Wonderroom(), new Trickroom() },
			[55] = new List<Move>() { new Shadowball() },
			[68] = new List<Move>() { new Nastyplot() },
			[75] = new List<Move>() { new Psychic() },
			[85] = new List<Move>() { new Hyperspacehole() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Block(), new Brickbreak(), new Calmmind(), new Chargebeam(), new Confide(), new Covet(), new Darkpulse(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Dualchop(), new Embargo(), new Energyball(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focuspunch(), new Foulplay(), new Frustration(), new Gigaimpact(), new Grassknot(), new Gravity(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Knockoff(), new Laserfocus(), new Lastresort(), new Lightscreen(), new Magiccoat(), new Magicroom(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Quash(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Roleplay(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thief(), new Throatchop(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Toxic(), new Trick(), new Trickroom(), new Uproar(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 90;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}