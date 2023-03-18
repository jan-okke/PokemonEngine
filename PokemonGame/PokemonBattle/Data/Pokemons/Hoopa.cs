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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Magician() };
		public override Stats BaseStats => new Stats(80, 110, 60, 150, 130, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Hyperspacehole(), new Moves.Trick(), new Moves.Destinybond(), new Moves.Allyswitch(), new Moves.Confusion() },
			[6] = new List<Move>() { new Moves.Astonish() },
			[10] = new List<Move>() { new Moves.Magiccoat() },
			[15] = new List<Move>() { new Moves.Lightscreen() },
			[19] = new List<Move>() { new Moves.Psybeam() },
			[25] = new List<Move>() { new Moves.Skillswap() },
			[29] = new List<Move>() { new Moves.Powersplit(), new Moves.Guardsplit() },
			[35] = new List<Move>() { new Moves.Phantomforce() },
			[46] = new List<Move>() { new Moves.Zenheadbutt() },
			[50] = new List<Move>() { new Moves.Wonderroom(), new Moves.Trickroom() },
			[55] = new List<Move>() { new Moves.Shadowball() },
			[68] = new List<Move>() { new Moves.Nastyplot() },
			[75] = new List<Move>() { new Moves.Psychic() },
			[85] = new List<Move>() { new Moves.Hyperspacehole() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Block(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Dualchop(), new Moves.Embargo(), new Moves.Energyball(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gravity(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Knockoff(), new Moves.Laserfocus(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Quash(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Toxic(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
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