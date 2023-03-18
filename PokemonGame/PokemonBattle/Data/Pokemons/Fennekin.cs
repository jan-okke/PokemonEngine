using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Fennekin : Pokemon
	{
		public override string Name => "Fennekin";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magician() };
		public override Stats BaseStats => new Stats(40, 45, 40, 62, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Tailwhip() },
			[5] = new List<Move>() { new Ember() },
			[11] = new List<Move>() { new Howl() },
			[14] = new List<Move>() { new Flamecharge() },
			[17] = new List<Move>() { new Psybeam() },
			[20] = new List<Move>() { new Firespin() },
			[25] = new List<Move>() { new Luckychant() },
			[27] = new List<Move>() { new Lightscreen() },
			[31] = new List<Move>() { new Psyshock() },
			[35] = new List<Move>() { new Flamethrower() },
			[38] = new List<Move>() { new Willowisp() },
			[41] = new List<Move>() { new Psychic() },
			[43] = new List<Move>() { new Sunnyday() },
			[46] = new List<Move>() { new Magicroom() },
			[48] = new List<Move>() { new Fireblast() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Embargo(), new Facade(), new Fireblast(), new Firepledge(), new Flamecharge(), new Flamethrower(), new Foulplay(), new Frustration(), new Grassknot(), new Heatwave(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Magiccoat(), new Magicroom(), new Overheat(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Toxic(), new Willowisp(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Heatwave(), new Hypnosis(), new Magiccoat(), new Psychicterrain(), new Wish() };
		public override int Weight => 94;
		public override int ExpYield => 61;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}