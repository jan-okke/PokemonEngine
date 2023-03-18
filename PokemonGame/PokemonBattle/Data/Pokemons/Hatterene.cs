using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hatterene : Pokemon
	{
		public override string Name => "Hatterene";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Healer(), new Abilities.Anticipation() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Magicbounce() };
		public override Stats BaseStats => new Stats(57, 90, 95, 136, 103, 29);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Psychocut() },
			[1] = new List<Move>() { new Moves.Psychocut(), new Moves.Brutalswing(), new Moves.Confusion(), new Moves.Playnice(), new Moves.Lifedew(), new Moves.Disarmingvoice() },
			[15] = new List<Move>() { new Moves.Aromatherapy() },
			[20] = new List<Move>() { new Moves.Psybeam() },
			[25] = new List<Move>() { new Moves.Healpulse() },
			[30] = new List<Move>() { new Moves.Dazzlinggleam() },
			[37] = new List<Move>() { new Moves.Calmmind() },
			[46] = new List<Move>() { new Moves.Psychic() },
			[55] = new List<Move>() { new Moves.Healingwish() },
			[64] = new List<Move>() { new Moves.Magicpowder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Brutalswing(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Magicroom(), new Moves.Mistyexplosion(), new Moves.Mysticalfire(), new Moves.Playrough(), new Moves.Powerswap(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Thunderwave(), new Moves.Trickroom(), new Moves.Wonderroom() };
		public override int Weight => 51;
		public override int ExpYield => 255;
		public override int CatchRate => 45;
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