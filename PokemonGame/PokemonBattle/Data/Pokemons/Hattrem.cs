using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hattrem : Pokemon
	{
		public override string Name => "Hattrem";
		public override List<Ability> AvailableAbilities => new() {new Healer(), new Anticipation() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicbounce() };
		public override Stats BaseStats => new Stats(57, 40, 65, 86, 73, 49);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Brutalswing() },
			[1] = new List<Move>() { new Brutalswing(), new Confusion(), new Playnice(), new Lifedew(), new Disarmingvoice() },
			[15] = new List<Move>() { new Aromatherapy() },
			[20] = new List<Move>() { new Psybeam() },
			[25] = new List<Move>() { new Healpulse() },
			[30] = new List<Move>() { new Dazzlinggleam() },
			[37] = new List<Move>() { new Calmmind() },
			[44] = new List<Move>() { new Psychic() },
			[51] = new List<Move>() { new Healingwish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Brutalswing(), new Calmmind(), new Charm(), new Darkpulse(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Expandingforce(), new Facade(), new Gigadrain(), new Helpinghand(), new Hiddenpower(), new Imprison(), new Lightscreen(), new Magicalleaf(), new Mysticalfire(), new Playrough(), new Protect(), new Psychic(), new Psyshock(), new Rest(), new Round(), new Safeguard(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Thunderwave() };
		public override int Weight => 48;
		public override int ExpYield => 130;
		public override int CatchRate => 120;
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