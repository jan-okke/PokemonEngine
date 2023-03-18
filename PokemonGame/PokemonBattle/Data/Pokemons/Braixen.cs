using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Braixen : Pokemon
	{
		public override string Name => "Braixen";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magician() };
		public override Stats BaseStats => new Stats(59, 59, 58, 90, 70, 73);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Tailwhip(), new Ember() },
			[5] = new List<Move>() { new Ember() },
			[11] = new List<Move>() { new Howl() },
			[14] = new List<Move>() { new Flamecharge() },
			[18] = new List<Move>() { new Psybeam() },
			[22] = new List<Move>() { new Firespin() },
			[28] = new List<Move>() { new Luckychant() },
			[31] = new List<Move>() { new Lightscreen() },
			[36] = new List<Move>() { new Psyshock() },
			[41] = new List<Move>() { new Flamethrower() },
			[45] = new List<Move>() { new Willowisp() },
			[49] = new List<Move>() { new Psychic() },
			[52] = new List<Move>() { new Sunnyday() },
			[56] = new List<Move>() { new Magicroom() },
			[59] = new List<Move>() { new Fireblast() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Embargo(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Flamecharge(), new Flamethrower(), new Foulplay(), new Frustration(), new Grassknot(), new Heatwave(), new Hiddenpower(), new Irontail(), new Laserfocus(), new Lightscreen(), new Lowkick(), new Magiccoat(), new Magicroom(), new Overheat(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Rest(), new Return(), new Round(), new Safeguard(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Telekinesis(), new Thief(), new Thunderpunch(), new Toxic(), new Trick(), new Willowisp(), new Wonderroom(), new Workup(), new Zenheadbutt() };
		public override int Weight => 145;
		public override int ExpYield => 143;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}